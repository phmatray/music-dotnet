using Windows.UI.Xaml;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using OpenJam.SamplePages.ConfigureMidi;
using OpenJam.SamplePages.DegreeInfo;
using OpenJam.SamplePages.IntervalCalculator;
using OpenJam.SamplePages.NoteFinder;
using OpenJam.SamplePages.ScaleInfo;

namespace OpenJam.SamplePages
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        public static ViewModelLocator Instance
            => Application.Current.Resources["Locator"] as ViewModelLocator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocator"/> class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
            }
            else
            {
                // Create run time view services and models
            }

            // Register your services used here
            SimpleIoc.Default.Register<INavigationService, NavigationService>();

            // SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<ConfigureMidiViewModel>();
            SimpleIoc.Default.Register<DegreeInfoViewModel>();
            SimpleIoc.Default.Register<ScaleInfoViewModel>();
            SimpleIoc.Default.Register<NoteFinderViewModel>();
            SimpleIoc.Default.Register<IntervalCalculatorViewModel>();
        }

        // <summary>
        // Gets the ConfigureMidi view model.
        // </summary>
        // <value>
        // The ConfigureMidi view model.
        // </value>
        public ConfigureMidiViewModel ConfigureMidiInstance
            => ServiceLocator.Current.GetInstance<ConfigureMidiViewModel>();

        // <summary>
        // Gets the DegreeInfo view model.
        // </summary>
        // <value>
        // The DegreeInfo view model.
        // </value>
        public DegreeInfoViewModel DegreeInfoInstance
            => ServiceLocator.Current.GetInstance<DegreeInfoViewModel>();

        // <summary>
        // Gets the ScaleInfo view model.
        // </summary>
        // <value>
        // The ScaleInfo view model.
        // </value>
        public ScaleInfoViewModel ScaleInfoInstance
            => ServiceLocator.Current.GetInstance<ScaleInfoViewModel>();

        // <summary>
        // Gets the NoteFinder view model.
        // </summary>
        // <value>
        // The NoteFinder view model.
        // </value>
        public NoteFinderViewModel NoteFinderInstance
            => ServiceLocator.Current.GetInstance<NoteFinderViewModel>();

        // <summary>
        // Gets the IntervalCalculator view model.
        // </summary>
        // <value>
        // The IntervalCalculator view model.
        // </value>
        public IntervalCalculatorViewModel IntervalCalculatorInstance
            => ServiceLocator.Current.GetInstance<IntervalCalculatorViewModel>();

        // <summary>
        // The cleanup.
        // </summary>
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}