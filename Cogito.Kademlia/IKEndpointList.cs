﻿using System.Collections.Generic;

namespace Cogito.Kademlia
{

    /// <summary>
    /// Describes a list of endpoints.
    /// </summary>
    /// <typeparam name="TKNodeId"></typeparam>
    public interface IKEndpointList<TKNodeId> : ISet<IKEndpoint<TKNodeId>>
        where TKNodeId : unmanaged, IKNodeId<TKNodeId>
    {



    }

}