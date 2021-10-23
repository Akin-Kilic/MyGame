using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("Oyuncu eklendi: "+player.FirstName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi: " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi: " + player.FirstName);
        }
    }
}
