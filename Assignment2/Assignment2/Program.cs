using Assignment2.CustomerNotifications;
using Assignment2.MediaPlayerPlugins;
using Assignment2.VehicleControlSystem;

namespace Assignment2;

internal class Program
{
    static void Main(string[] args)
    {
        #region Payment Methods
        IPayment bankTransfer = new BankTransferPayment();
        IPayment creditCard = new CreditCardPayment();
        IPayment payPal = new PayPalPayment();
        Payment payment = new(payPal);
        // payment.ExecutePayment(100);
        #endregion

        #region Vehicle Control System
        Vehicle car = new Car();
        //car.Start();
        //car.Describe();
        //car.Stop();
        #endregion

        #region Media Player Plugins
        IMedia video = new Video();
        IMedia audio = new Audio();
        MediaPlayer podcast = new(audio);
        //podcast.Play();
        //podcast.Stop();
        #endregion

        #region Customer Notifications
        INotification email = new EmailNotification();
        NotificationService service = new(email);
        service.Notify("Welcome back !");
        #endregion

    }
}
