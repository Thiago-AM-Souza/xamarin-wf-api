using CadastroDesktop.Model;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDesktop.ContextoDataModel {

    /// <summary>
    /// IContextoUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IContextoUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Cliente entities repository.
        /// </summary>
		IRepository<Cliente, int> Cliente { get; }
    }
}
