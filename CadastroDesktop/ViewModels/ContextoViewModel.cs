using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using CadastroDesktop.ContextoDataModel;

namespace CadastroDesktop.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the Contexto data model.
    /// </summary>
    public partial class ContextoViewModel : DocumentsViewModel<ContextoModuleDescription, IContextoUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of ContextoViewModel as a POCO view model.
        /// </summary>
        public static ContextoViewModel Create() {
            return ViewModelSource.Create(() => new ContextoViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the ContextoViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ContextoViewModel type without the POCO proxy factory.
        /// </summary>
        protected ContextoViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override ContextoModuleDescription[] CreateModules() {
			return new ContextoModuleDescription[] {
                new ContextoModuleDescription( "Cliente", "ClienteCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Cliente)),
			};
        }
                		protected override void OnActiveModuleChanged(ContextoModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class ContextoModuleDescription : ModuleDescription<ContextoModuleDescription> {
        public ContextoModuleDescription(string title, string documentType, string group, Func<ContextoModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}