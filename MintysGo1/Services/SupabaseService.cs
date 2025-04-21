using Supabase;

namespace MintysGo1.Services
{
    public class SupabaseService
    {
        private static Supabase.Client _client;

        public static async Task<Supabase.Client> GetClient()
        {
            if (_client == null)
            {
                var url = "https://<your-project>.supabase.co";
                var key = "<your-anon-or-service-role-key>";
                var options = new SupabaseOptions
                {
                    AutoRefreshToken = true,
                    AutoConnectRealtime = true
                };

                _client = new Supabase.Client(url, key, options);
                await _client.InitializeAsync();
            }

            return _client;
        }
    }
}
