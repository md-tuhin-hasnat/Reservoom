using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomID => _reservation.RoomID?.ToString();
        public string UserName => _reservation.UserName;
        public DateTime StartTime => _reservation.StartTime;
        public DateTime EndTime => _reservation.EndTime;
        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
