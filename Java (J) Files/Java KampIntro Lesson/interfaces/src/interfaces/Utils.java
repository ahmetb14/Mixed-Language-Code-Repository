package interfaces;

public class Utils {

	public static void runLoggers(Logger[] loggers, String message) {

		for (Logger logger : loggers) {
			logger.log(message);
		}

	}

}
//Java da ana,dýþ class static yapýlamaz. Ana dýþ class içerisine oluþturulan,
//classa static verilebilir.
//Utils = Araçlar demektir C#da utilities e karþýþýk gelir.