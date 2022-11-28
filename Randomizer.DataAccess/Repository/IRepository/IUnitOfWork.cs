﻿namespace Randomizer.DataAccess.Repository.IRepository
{
    /// <summary>
    /// save will be used for every class this is a reusable class
    /// </summary>
    public interface IUnitOfWork
    {
        void Save();
    }
}
