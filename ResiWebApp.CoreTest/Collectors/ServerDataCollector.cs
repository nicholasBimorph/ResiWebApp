using System.Collections.Generic;
using Bimorph.WebApi.Core;
using Microsoft.AspNetCore.Components;

namespace ResiWebApp.CoreTest
{
    /// <summary>
    /// This class fetches <see cref="IBimorphObject" />'s
    /// from the server.
    /// </summary>
    public class ServerDataCollector
    {
        private readonly IBimorphFactory _bimorphTypeFactory;

        private readonly BimorphAPIClientService _bimorphApiClientService;

        private readonly string _getLatestNodeCollectionEndPoint = ApiEndPoints.GetLatestNodeCollectionEndPoint;

        private readonly string _getNodeCollectionByIdEndPoint = ApiEndPoints.GetNodeCollectionByIdEndPoint;

        private string _streamId;

        private bool _useLatestStreamId;

        /// <summary>
        /// Determines if any data could be fetched from
        /// the BimorphAPI server.
        /// </summary>
        public bool CouldFetch { get; private set; }


        /// <summary>
        /// Determines if the latest stream id will be used or not.
        /// </summary>
        [Parameter]
        public bool UseLatestStreamId
        {
            get => _useLatestStreamId;

            set => _useLatestStreamId = value;
        }

        /// <summary>
        /// The stream Id that should be used
        /// to retrieve data from the BimorphServer.
        /// </summary>
        [Parameter]
        public string StreamId
        {
            get => _streamId;

            set => _streamId = value;
        }

        /// <summary>
        /// Construct a <see cref="ServerDataCollector" />.
        /// </summary>
        /// <param name="bimorphApiClientService"></param>
        /// <param name="bimorphTypeFactory"></param>
        public ServerDataCollector(
            BimorphAPIClientService bimorphApiClientService,
            IBimorphFactory bimorphTypeFactory)
        {
            _bimorphTypeFactory = bimorphTypeFactory;

            _bimorphApiClientService = bimorphApiClientService;
        }

        /// <summary>
        /// Fetches a collection of <see cref="IBimorphObject" />
        /// from the server.
        /// </summary>
        public IList<IBimorphObject> Fetch()
        {
            if (this.UseLatestStreamId) 
                return this.ExtractBimorphObjects(_getLatestNodeCollectionEndPoint);

            string getByIdEndPoint = _getNodeCollectionByIdEndPoint + this.StreamId;

            return this.ExtractBimorphObjects(getByIdEndPoint);
        }

        /// <summary>
        /// Extracts the actual <see cref="IBimorphObject"/>'s
        /// from the deserialized json object.
        /// </summary>
        private IList<IBimorphObject> ExtractBimorphObjects(string urlEndpoint)
        {
            string jObject = _bimorphApiClientService.GetRequest(urlEndpoint);

            var bimorphObjects = _bimorphTypeFactory.CreateBimorphObjects(jObject);

            if (bimorphObjects == null)
            {
                this.CouldFetch = false;

                return null;
            }

            this.CouldFetch = true;

            return bimorphObjects;
        }
    }
}