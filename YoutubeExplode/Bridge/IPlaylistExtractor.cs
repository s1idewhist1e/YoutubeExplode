using System.Collections.Generic;

namespace YoutubeExplode.Bridge;

internal interface IPlaylistExtractor
{
    string? TryGetPlaylistTitle();

    string? TryGetPlaylistAuthor();

    string? TryGetPlaylistChannelId();

    int? TryGetPlaylistLength();

    string? TryGetPlaylistDescription();

    IReadOnlyList<ThumbnailExtractor> GetPlaylistThumbnails();
}