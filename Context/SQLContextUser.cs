using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using KillerAppSE2.Connector;
using KillerAppSE2.Interfaces;
using KillerAppSE2.Models;
using System.Data.SqlClient;

namespace KillerAppSE2.Context
{
    public class SQLContextUser : IContextUser
    {
        private MSSQLConnector _connector;

        public SQLContextUser(MSSQLConnector connector)
        {
            this._connector = connector;
        }

        public bool RegisterUser(Ouder User)
        {
            SqlCommand cmd = new SqlCommand("RegisterOuder");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Initialen", User.initialen);
            cmd.Parameters.AddWithValue("@Achternaam", User.achternaam);
            cmd.Parameters.AddWithValue("@LoginPin", User.loginPin);
            cmd.Parameters.AddWithValue("@MobielNr", User.mobielNr);
            cmd.Parameters.AddWithValue("@TelNr", User.telNr);
            cmd.Parameters.AddWithValue("@Email", User.email);
            cmd.Parameters.AddWithValue("@ThuisAdres", User.thuisAdres);
            cmd.Parameters.AddWithValue("@Leeftijd", User.leeftijd);

            try
            {
                _connector.ExecuteQueryCommand(cmd);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool RegisterUser(Student User)
        {
            SqlCommand cmd = new SqlCommand("RegisterStudent");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Init", User.initialen);
            cmd.Parameters.AddWithValue("@Achter", User.achternaam);
            cmd.Parameters.AddWithValue("@Login", User.loginPin);
            cmd.Parameters.AddWithValue("@Email", User.email);
            cmd.Parameters.AddWithValue("@Telnr", User.telNr);
            cmd.Parameters.AddWithValue("@ThuisAdres", User.thuisAdres);
            cmd.Parameters.AddWithValue("@StudLoc", User.studeerLocatie);

            try
            {
                _connector.ExecuteQueryCommand(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}