namespace CaliburnAutoFac.ViewModels
{
    public class SampleOneViewModel : IChildSampleViewModel
    {
        public string DisplayName { get; } = "UI Framework";
        public string Message { get; } = "Caliburn Micro";
    }
}