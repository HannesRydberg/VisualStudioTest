
public class RatingObject {
	
	private int rating = 1200;
	private String id;
	
	
	public void changeRating (int value){
		rating += value;
	}
	
	public int getRating(){
		return rating;
	}
	
	public String getID(){
		return id;
	}

}
