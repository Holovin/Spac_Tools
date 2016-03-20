using IPlugin;

namespace DSpacesApi {
    public class SpacesApi : IBasePlugin {
        public string Name => "Spaces API";
        public string Author => "DJ_miXxXer";
        public string Description => "Spaces API Helper tools";
        public string InnerName { get; } = "base.api";
        public string Link => "http://spaces.ru";
        public int Version => 1;
    }
}