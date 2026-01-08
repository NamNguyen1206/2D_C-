using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro15
{
    internal class ItemCollector
    {
        public delegate void ItemCollectedDelegate();

        public event ItemCollectedDelegate OnItemCollected;
        public ItemCollector()
        {
            OnItemCollected += UpdateScore;
            OnItemCollected += PlaySound;
            OnItemCollected += ShowItemPopup;
        }
        public void OnTriggerEnter(bool check)
        {
            if (check)
            {
                Console.WriteLine("Item collected!");
                Console.WriteLine("Notifying subscribers...");
                OnItemCollected?.Invoke();
                Console.WriteLine("All subscribers have been notified.");

            }
        }
        void UpdateScore()
        {
            Console.WriteLine("Score updated!");
        }
        void PlaySound()
        {
            Console.WriteLine("Playing collection sound!");
        }
        void ShowItemPopup()
        {
            Console.WriteLine("Showing item collected popup!");
        }
    }
}
