import java.awt.Robot;


public class Test {
	
	private static RatingObject ro;

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		ro = new RatingObject();
		ro.changeRating(-100);
		System.out.println(ro.getRating());
		int i = (int)(Math.random() * 100);
		System.out.println(i);
	}

}
