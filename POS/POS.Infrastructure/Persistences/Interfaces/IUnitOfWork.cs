﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category { get; }

        void SaveChanges();
        Task SaveChangesAsync();

    }
}
