namespace CaliburnAutoFac.ViewModels
{
    public class SampleTwoViewModel : IChildSampleViewModel
    {
        public string DisplayName { get; } = "Sample Two";
        public string Message { get; } = "This is the second sample.";
    }
}