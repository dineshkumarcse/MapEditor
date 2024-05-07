using MapEditor.Commands;
using MapEditor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MapEditor.ViewModel
{
    class MapEditorViewModel
    {
        private long gridHeight;
        private long gridWidth;
        public DelegateCommand<object> ResetButtonCommand { get; set; }
        MapEditorModel model=new MapEditorModel();
        public MapEditorViewModel()
        {
            ResetButtonCommand = new DelegateCommand<object>(OnResetButtonCommand);

        }

        private async void OnResetButtonCommand(object obj)
        {
           GeneralTabViewModel viewModel = new GeneralTabViewModel();
            gridHeight = viewModel.GridHeight;
            gridWidth = viewModel.GridWidth;
            model.CreateCirclesWithNotch(gridHeight, gridWidth);
        }

    }
}
