// Create modern music player
using adapter;

IMusicPlayer modernPlayer = new ModerMusicPlayer();
Console.WriteLine("Testing Modern Music Player:");
modernPlayer.Play();
modernPlayer.NextTrack();
modernPlayer.Stop();

Console.WriteLine();

// Create and test Cassette Player with Adapter
IMusicPlayer cassettePlayerAdapter = new CassettePlayerAdapter(new CassetePlayer());
Console.WriteLine("Testing Cassette Player with Adapter:");
cassettePlayerAdapter.Play();
cassettePlayerAdapter.NextTrack(); // Should handle or ignore, since there's no concept of 'next' in cassette players
cassettePlayerAdapter.Stop();

Console.WriteLine();

// Create and test Record Player with Adapter
IMusicPlayer recordPlayerAdapter = new RecordPlayerAdapter(new RecordPlayer());
Console.WriteLine("Testing Record Player with Adapter:");
recordPlayerAdapter.Play();
recordPlayerAdapter.NextTrack(); // Should handle or ignore, similar to cassette players
recordPlayerAdapter.Stop();