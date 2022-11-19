namespace CoreWPFMVVM.UI.Utilities
{
    /// <summary>
    /// IFileDragDropTarget Interface
    /// </summary>
    public interface IFileDragDropTarget
    {
        void OnFileDrop(string[] filepaths);
    }
}
