namespace sirocco.matmod.ViewModels;
using System.Collections.ObjectModel;
    public class ReadinessModelViewModel
    {
        public ObservableCollection<ReadinessModel> ReadinessData { get; set; }

        public ReadinessModelViewModel()
        {
            ReadinessData = new ObservableCollection<ReadinessModel>
            {
                new ReadinessModel
                {
                    Category = "Data Structure",
                    Levels = new List<string> { "Unstructured", "Partially Structured", "Standardized", "AI-ready", "Fully Optimized" }
                },
                new ReadinessModel
                {
                    Category = "People",
                    Levels = new List<string> { "No AI Training", "Small Interest", "AI Training", "AI Roles Emerging", "AI Experts Available" }
                },
                new ReadinessModel
                {
                    Category = "Governance",
                    Levels = new List<string> { "No AI Strategy", "Developing Strategy", "Leadership Engaged", "AI Governance in Place", "AI-Driven Decisions" }
                },
                new ReadinessModel
                {
                    Category = "Systems & Processes",
                    Levels = new List<string> { "Fragmented", "Viewing AI Potential", "Process Improvement", "AI-Adaptive", "Fully AI-Integrated" }
                }
            };
        }
    }

