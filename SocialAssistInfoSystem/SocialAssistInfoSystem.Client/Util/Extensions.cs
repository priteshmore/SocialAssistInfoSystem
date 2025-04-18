using System.Collections.ObjectModel;

namespace SocialAssistInfoSystem.Client.Util
{
    public static class Extensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
            => new ObservableCollection<T>(source);
    }

}
