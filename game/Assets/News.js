
private var myStrings : String[] = ['Stockmarkets continue to rise','  Bear spotted in Japan','  Reddit Catches Fire!','  Massive diamond heist in Mexico','  Eggs, a new wonder food?',' Is Canada Evil?'];
private var timer: float = 0;
private var i: int = 0;


private var textMeshComponent;

// store the text component so that GetComponent isn’t called every frame

function Start() {
	textMeshComponent = GetComponent('TextMesh');
}
function Update() {
	timer -= Time.deltaTime;
	if (timer < 0){
		timer = 10;
		i += 1;
		textMeshComponent.text = 'News:'+ '\n' + myStrings[i%6];
	}
}