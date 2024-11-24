using System.Collections;
using UnityEngine;
using System.Threading.Tasks;
using System;

namespace Timer
{
    public class GlobalTimer
    {
        private float _waitingTime = 5;
        public float WaitingTime { get => _waitingTime; set => _waitingTime = value; }
        public delegate void TimerEndedDelegate();
        public event TimerEndedDelegate TimerEnded;

        public async Task TimerEnd()
        {
            try
            {
                while (true) 
                {
                    DateTime targetTime = DateTime.Now.AddSeconds(_waitingTime);
                    
                    while (DateTime.Now < targetTime)
                    {
                        await Task.Delay(100);
                    }

                    TimerEnded?.Invoke();
                }
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}
