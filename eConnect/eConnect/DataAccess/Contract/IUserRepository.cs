﻿namespace eConnect.DataAccess.Contract
{
    public interface IUserRepository
    {
        bool ValidateUser(string username, string password);
    }
}
