namespace Exercicio20.Services {
    interface IOnlinePaymentService {

        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}