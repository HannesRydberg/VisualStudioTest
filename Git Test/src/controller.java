public class controller {
	private database db = new database();

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
		return db.getRatingObject(id);
	}

	/**
	 * Returns a pseudo random RatingObject from the database with uniform
	 * distribution
	 * 
	 * @return Random RatingObject
	 */
	public RatingObject getRandom() {
		return db.getRandom();
	}

	/**
	 * Adds a RatingObject to the database
	 * 
	 * @param ro
	 *            The RatingObject to be added
	 */
	public void addRatinObject(RatingObject ro) {
		db.addRatingObject(ro);
	}
}
