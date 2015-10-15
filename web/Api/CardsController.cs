﻿namespace Skeleton.Api {
    using Cards;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    [RoutePrefix("api/projects/{projectName}/cards")]
    public class CardsController : ApiController {
        readonly ICardsClient _client;

        public CardsController(ICardsClient client) {
            _client = client;
        }

        [Route("")]
        public async Task<IEnumerable<Card>> Get(string projectName, int depth = 0) {
            return await _client.GetCards(projectName, depth);
        }

        [Route("")]
        public async Task Put(IEnumerable<Card> cards) {
            await _client.UpdateCards(cards);
        }
    }
}
