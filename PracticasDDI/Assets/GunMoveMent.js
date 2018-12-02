
 
	
function Start(){

	DefaultPos = transform.localPosition;

}
	
	
function Update () {

	MoveOnX = Input.GetAxis( "Mouse X" ) *Time.deltaTime * MoveAmount;
	
	MoveOnY = Input.GetAxis( "Mouse Y" ) *Time.deltaTime * MoveAmount;
	
	NewGunPos = new Vector3 ( DefaultPos.x+ MoveOnX, DefaultPos.y+ MoveOnY, DefaultPos.z);
	
	GUN.transform.localPosition = Vector3.Lerp(GUN.transform.localPosition, NewGunPos , MoveSpeed * Time.deltaTime);

}