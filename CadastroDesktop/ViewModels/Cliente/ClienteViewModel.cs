using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using CadastroDesktop.ContextoDataModel;
using CadastroDesktop.Common;
using CadastroDesktop.Model;

namespace CadastroDesktop.ViewModels {

    /// <summary>
    /// Represents the single Cliente object view model.
    /// </summary>
    public partial class ClienteViewModel : SingleObjectViewModel<Cliente, int, IContextoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ClienteViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ClienteViewModel Create(IUnitOfWorkFactory<IContextoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ClienteViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ClienteViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClienteViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ClienteViewModel(IUnitOfWorkFactory<IContextoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Cliente, x => x.nome) {
                }



    }
}
