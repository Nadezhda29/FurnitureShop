using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using FurnitureShop.Infrastructure;

namespace FurnitureShop.Models
{
    public class SessionCart: Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();

            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Furniture furniture, int quantity)
        {
            base.AddItem(furniture, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Furniture furniture)
        {
            base.RemoveLine(furniture);
            Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
