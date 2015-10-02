import java.util.ArrayList;

/**
 * @author Hannes
 *
 */
public class database {

	private ArrayList<RatingObject> ratingList = new ArrayList<RatingObject>();

	/**
	 * Returns the RatingObject in the database with the matching ID, null if
	 * there is no such RatingObject
	 * 
	 * @param id
	 *            id for the RatingObject to be returned
	 * @return The RatingObject with matching ID from the database. If no such
	 *         object exists return null.
	 */
	public RatingObject getRatingObject(String id) {
		for (RatingObject o : ratingList) {
			if (o.getID() == id) {
				return o;
			}
		}
		return null;

	}

	/**
	 * Returns a pseudo random RatingObject from the database with uniform
	 * distribution
	 * 
	 * @return Random RatingObject
	 */

	public RatingObject getRandom() {
		int index = (int) (Math.random() * ratingList.size());
		return ratingList.get(index);
	}

	/**
	 * Adds a RatingObject to the database
	 * 
	 * @param ro
	 *            The RatingObject to be added
	 */
	public void addRatingObject(RatingObject ro) {
		ratingList.add(ro);
	}

}
