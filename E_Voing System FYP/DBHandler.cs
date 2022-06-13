using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Voing_System_FYP
{
    public class DBHandler
    {
        String connectionStr;
        public DBHandler()
        {
            connectionStr = "server = localhost; database=e_voting; User Id=root; password=;";
            //MySqlConnection con = new MySqlConnection(connectionStr);
            //con.Open();
            //String query = "INSERT INTO `elections` (`Name`, `Date`, `StartTime`, `EndTime`, `PresidentsCount`, `VicePresidentsCount`, `SecretaryCount`, `TreasurerCount`, `Status`) VALUES (@name, @date, @time1, @time2, @pc, @vpc, @sc, @tc, '0');";
            //MySqlCommand cmd = new MySqlCommand(query, con);
            //cmd.Parameters.Add(new MySqlParameter("@name", "1233qw"));
            //cmd.Parameters.Add(new MySqlParameter("@date", "2022-10-10"));
            //cmd.Parameters.Add(new MySqlParameter("@time1", "08:00:00"));
            //cmd.Parameters.Add(new MySqlParameter("@time2", "05:00:00"));
            //cmd.Parameters.Add(new MySqlParameter("@pc", 2));
            //cmd.Parameters.Add(new MySqlParameter("@vpc", 2));
            //cmd.Parameters.Add(new MySqlParameter("@sc", 2));
            //cmd.Parameters.Add(new MySqlParameter("@tc", 2));
            //cmd.ExecuteNonQuery();
        }
        public void insertElection(Election election)
        {
            MySqlConnection con = new MySqlConnection(connectionStr);
            con.Open();
            String query = "INSERT INTO `elections` (`Name`, `Date`, `StartTime`, `EndTime`, `PresidentsCount`, `VicePresidentsCount`, `SecretaryCount`, `TreasurerCount`, `Status`) VALUES (@name, @date, @time1, @time2, @pc, @vpc, @sc, @tc, '0');";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add(new MySqlParameter("@name", election.electionName));
            cmd.Parameters.Add(new MySqlParameter("@date", election.date));
            cmd.Parameters.Add(new MySqlParameter("@time1", election.startTime));
            cmd.Parameters.Add(new MySqlParameter("@time2", election.endTime));
            cmd.Parameters.Add(new MySqlParameter("@pc", election.pCand));
            cmd.Parameters.Add(new MySqlParameter("@vpc", election.vpCand));
            cmd.Parameters.Add(new MySqlParameter("@sc", election.sCand));
            cmd.Parameters.Add(new MySqlParameter("@tc", election.tCand));
            cmd.ExecuteNonQuery();
            con.Close();
            foreach (Candidate cand in election.pCandidates)
            {
                insertCandidate(election.date, cand);
            }
            foreach (Candidate cand in election.vpCandidates)
            {
                insertCandidate(election.date, cand);
            }
            foreach (Candidate cand in election.sCandidates)
            {
                insertCandidate(election.date, cand);
            }
            foreach (Candidate cand in election.tCandidates)
            {
                insertCandidate(election.date, cand);
            }
        }

        public void insertCandidate(String Elec_Id, Candidate candidate)
        {
            MySqlConnection con = new MySqlConnection(connectionStr);
            con.Open();
            String query = "INSERT INTO `candidates` (`Elect_Key`, `Picture`, `CNIC`, `Position`) VALUES (@key, @pic, @cnic, @pos);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add(new MySqlParameter("@key", Elec_Id));
            cmd.Parameters.Add(new MySqlParameter("@pic", candidate.getImageData()));
            cmd.Parameters.Add(new MySqlParameter("@cnic", candidate.getCNIC()));
            cmd.Parameters.Add(new MySqlParameter("@pos", candidate.getPosition()));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public ArrayList getAllElections()
        {
            MySqlConnection con = new MySqlConnection(connectionStr);
            con.Open();
            String query = "Select * from `elections`;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            ArrayList elections = new ArrayList(); 
            while (reader.Read())
            {
                Election election = new Election();
                election.electionName = reader[0].ToString();
                election.date = reader[1].ToString().Split(' ')[0];
                election.startTime = reader[2].ToString();
                election.endTime = reader[3].ToString();
                election.pCand = (int)reader[4];
                election.vpCand = (int)reader[5];
                election.sCand = (int)reader[6];
                election.tCand = (int)reader[7];
                election.status = (int)reader[8];
                elections.Add(election);
                ArrayList candidates = getCandidate(election.date);
                foreach (Candidate candidate in candidates)
                {
                    if (candidate.getPosition() == "p")
                    {
                        election.pCandidates.Add(candidate);
                    }
                    if (candidate.getPosition() == "vp")
                    {
                        election.vpCandidates.Add(candidate);
                    }
                    if (candidate.getPosition() == "s")
                    {
                        election.sCandidates.Add(candidate);
                    }
                    if (candidate.getPosition() == "t")
                    {
                        election.tCandidates.Add(candidate);
                    }
                }
            }
            reader.Close();
            con.Close();
            return elections;
        }
        public Election getElection(String elec_date)
        {
            MySqlConnection con = new MySqlConnection(connectionStr);
            con.Open();
            String query = "Select * from `elections` where Date like @date";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add(new MySqlParameter("@date", elec_date));
            MySqlDataReader reader = cmd.ExecuteReader();
            Election election = new Election();
            while (reader.Read())
            {
                election.electionName = reader[0].ToString();
                election.date = reader[1].ToString().Split(' ')[0];
                election.startTime = reader[2].ToString();
                election.endTime = reader[3].ToString();
                election.pCand = (int)reader[4];
                election.vpCand = (int)reader[5];
                election.sCand = (int)reader[6];
                election.tCand = (int)reader[7];
                election.status = (int)reader[8];
            }
            reader.Close();
            con.Close();
            ArrayList candidates = getCandidate(elec_date);
            foreach (Candidate candidate in candidates)
            {
                if (candidate.getPosition() == "p")
                {
                    election.pCandidates.Add(candidate);
                }
                if (candidate.getPosition() == "vp")
                {
                    election.vpCandidates.Add(candidate);
                }
                if (candidate.getPosition() == "s")
                {
                    election.sCandidates.Add(candidate);
                }
                if (candidate.getPosition() == "t")
                {
                    election.tCandidates.Add(candidate);
                }
            }
            return election;
        }
        public ArrayList getCandidate(String elec_date)
        {
            MySqlConnection con = new MySqlConnection(connectionStr);
            con.Open();
            String query = "Select * from `candidates` where Elect_Key like @date";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add(new MySqlParameter("@date", elec_date));
            MySqlDataReader reader = cmd.ExecuteReader();
            Election election = new Election();
            ArrayList candidates = new ArrayList();
            while (reader.Read())
            {
                candidates.Add(new Candidate(reader[1].ToString(), (byte[])reader[2], reader[3].ToString()));
            }
            con.Close();
            reader.Close();
            return candidates;

        }
    }
}
