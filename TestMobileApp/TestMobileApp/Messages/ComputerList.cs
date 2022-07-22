using System;

namespace TestMobileApp.Messages
{
    public class ComputerList
    {
        /// <summary>
        /// Псевдоним компьютера, введенный пользователем в веб-интерфейсе
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Название компьютера, указанное в десктопной программе
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// идентификатор компьютера в системе
        /// этот идентификатор генерит десктопная программа
        /// </summary>
        public string ComputerId { get; set; }

        /// <summary>
        /// Запущено ли сейчас видео на компьютере.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Дата последнего изменения статуса
        /// </summary>  
        public DateTime LastChangeStatusDate { get; set; }
    }
}
