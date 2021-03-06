﻿using System.Threading;
using System.Threading.Tasks;
using FluentSpotifyApi.Model;

namespace FluentSpotifyApi.Builder.Me.Personalization.RecentlyPlayed
{
    /// <summary>
    /// The builder for "me/player/recently-played" endpoint.
    /// </summary>
    public interface IRecentlyPlayedTracksBuilder
    {
        /// <summary>
        /// Get tracks from the current user’s recently played tracks.
        /// </summary>
        /// <param name="limit">The maximum number of items to return. Default: 20. Minimum: 1. Maximum: 50.</param>
        /// <param name="after">A Unix timestamp in milliseconds. Returns all items after (but not including) this cursor position.</param>
        /// <param name="before">A Unix timestamp in milliseconds. Returns all items before (but not including) this cursor position.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<CursorBasedPage<PlayHistory>> GetAsync(int limit = 20, long? after = null, long? before = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
