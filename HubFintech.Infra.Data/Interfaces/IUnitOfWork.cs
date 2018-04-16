﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HubFintech.Infra.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}