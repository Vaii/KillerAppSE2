using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppSE2.Connector;
using KillerAppSE2.Interfaces;
using KillerAppSE2.Models;

namespace KillerAppSE2.Context
{
    public class SQLContextUser : IContextUser
    {
        private MSSQLConnector _connector;

        public SQLContextUser(MSSQLConnector connector)
        {
            this._connector = connector;
        }

        public bool RegisterUser(UserOuder Ouder)
        {
            return true;
        }
    }
}