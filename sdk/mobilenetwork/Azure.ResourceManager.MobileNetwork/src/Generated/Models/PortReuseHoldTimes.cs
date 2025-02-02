// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The minimum time (in seconds) that will pass before a port that was used by a closed pinhole can be recycled for use by another pinhole. All hold times must be minimum 1 second. </summary>
    public partial class PortReuseHoldTimes
    {
        /// <summary> Initializes a new instance of PortReuseHoldTimes. </summary>
        public PortReuseHoldTimes()
        {
        }

        /// <summary> Initializes a new instance of PortReuseHoldTimes. </summary>
        /// <param name="tcp"> Minimum time in seconds that will pass before a TCP port that was used by a closed pinhole can be reused. Default for TCP is 2 minutes. </param>
        /// <param name="udp"> Minimum time in seconds that will pass before a UDP port that was used by a closed pinhole can be reused. Default for UDP is 1 minute. </param>
        internal PortReuseHoldTimes(int? tcp, int? udp)
        {
            Tcp = tcp;
            Udp = udp;
        }

        /// <summary> Minimum time in seconds that will pass before a TCP port that was used by a closed pinhole can be reused. Default for TCP is 2 minutes. </summary>
        public int? Tcp { get; set; }
        /// <summary> Minimum time in seconds that will pass before a UDP port that was used by a closed pinhole can be reused. Default for UDP is 1 minute. </summary>
        public int? Udp { get; set; }
    }
}
