using System;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CoreWPFMVVM.UI.Utilities;

namespace CoreWPFMVVM.ViewModels
{
    /// <summary>
    /// Workspace viewmodel
    /// Implements IFileDragDropTarget to allow drag/drop
    /// </summary>
    public class WorkspaceViewModel : ObservableValidator, IFileDragDropTarget
    {
        #region Properties

        private string _title = "Charles";
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(2,ErrorMessage ="Length must be more than 2")]
        public string Title
        {
            get => _title;
            set
            {
                SetProperty(ref _title, value);
                ValidateProperty(Title, nameof(Title));
            }
        }
        #endregion

        #region Commands

        private RelayCommand<string> _buttonClickCommand;

        public RelayCommand<string> ButtonCommand => _buttonClickCommand 
            ?? (_buttonClickCommand = new RelayCommand<string>(ExecuteSaveCommand));

        private void ExecuteSaveCommand(string obj)
        {
            throw new NotImplementedException();
        }
        #endregion
        /// <summary>
        /// Action for file being dropped
        /// </summary>
        /// <param name="filepaths">filenames dropped.</param>
        public void OnFileDrop(string[] filepaths)
        {
            throw new NotImplementedException();
        }
    }
}
