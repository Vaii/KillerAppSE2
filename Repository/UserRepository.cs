using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppSE2.Interfaces;
using KillerAppSE2.Models;

namespace KillerAppSE2.Repository
{
    public class UserRepository
    {
        private IContextUser _iContextUser;

        public UserRepository(IContextUser context)
        {
            this._iContextUser = context;
        }

        public bool UserRegister(Ouder User)
        {
            return _iContextUser.RegisterUser(User);
        }

        public bool UserRegister(Student User)
        {
            return _iContextUser.RegisterUser(User);
        }
    }
}