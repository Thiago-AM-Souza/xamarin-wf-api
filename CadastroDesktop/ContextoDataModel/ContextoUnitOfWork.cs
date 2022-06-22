using CadastroDesktop.Model;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDesktop.ContextoDataModel {

    /// <summary>
    /// A ContextoUnitOfWork instance that represents the run-time implementation of the IContextoUnitOfWork interface.
    /// </summary>
    public class ContextoUnitOfWork : DbUnitOfWork<Contexto>, IContextoUnitOfWork {

        public ContextoUnitOfWork(Func<Contexto> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Cliente, int> IContextoUnitOfWork.Cliente {
            get { return GetRepository(x => x.Set<Cliente>(), (Cliente x) => x.id); }
        }
    }
}
