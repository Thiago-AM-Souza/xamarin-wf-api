using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using CadastroDesktop.ContextoDataModel;
using CadastroDesktop.Common;
using CadastroDesktop.Model;

namespace CadastroDesktop.ViewModels {

    /// <summary>
    /// Represents the Cliente collection view model.
    /// </summary>
    public partial class ClienteCollectionViewModel : CollectionViewModel<Cliente, int, IContextoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ClienteCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ClienteCollectionViewModel Create(IUnitOfWorkFactory<IContextoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ClienteCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ClienteCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClienteCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ClienteCollectionViewModel(IUnitOfWorkFactory<IContextoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Cliente) {
        }
    }
}