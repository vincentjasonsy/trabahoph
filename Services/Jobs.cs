using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabahoPH.Models.Entities;

namespace TrabahoPH.Services
{
    public class Jobs : DBConnection
    {
        public static Job GetJob(Guid id)
        {
            try
            {
                MyConn.Open();
                MySqlCommand cmd =
                    new MySqlCommand("SELECT j.id, i.title, j.description FROM jobs j WHERE j.id = '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(id.ToString()) + "'", MyConn);

                Job job = null;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    job = new Job
                    {
                        Id = rdr.GetGuid(0),
                        Title = rdr.GetString(1),
                        Description = rdr.GetString(2)
                    };
                }

                return job;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Oooppss {e.Message}");
                return null;
            }
            finally
            {
                MyConn.Close();
            }
        }

        public static IList<Job> GetJobsByAccount(Guid id)
        {
            return null;
        }

        public static IList<Job> GetJobsByAccount(string username)
        {
            return null;
        }

        public static Account GetAccount(string username)
        {
            try
            {
                MyConn.Open();
                MySqlCommand cmd = 
                    new MySqlCommand("SELECT a.id, a.username, a.password, u.id, u.name, u.email FROM account a INNER JOIN user u ON a.fk_user_id = u.id WHERE a.username = '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(username) + "'", MyConn);

                Account account = null;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    account = new Account
                    {
                        Id = rdr.GetGuid(0),
                        Username = rdr.GetString(1),
                        Password = rdr.GetString(2),
                        User = new User
                        {
                            Id = rdr.GetGuid(3),
                            Name = rdr.GetString(4),
                            Email = rdr.GetString(5)
                        }
                    };
                }

                return account;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Oooppss {e.Message}");
                return null;
            }
            finally
            {
                MyConn.Close();
            }
        }

        public static IList<Account> GetAccounts()
        {
            try
            {
                MyConn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT a.id, a.username, a.password, u.id, u.name, u.email FROM account a INNER JOIN user u ON a.fk_user_id = u.id", MyConn);

                var accounts = new List<Account>();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    accounts.Add(new Account
                    {
                        Id = rdr.GetGuid(0),
                        Username = rdr.GetString(1),
                        Password = rdr.GetString(2),
                        User = new User
                        {
                            Id = rdr.GetGuid(3),
                            Name = rdr.GetString(4),
                            Email = rdr.GetString(5)
                        }
                    });
                }

                return accounts;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Oooppss {e.Message}");
                return null;
            }
            finally
            {
                MyConn.Close();
            }
        }
    }
}