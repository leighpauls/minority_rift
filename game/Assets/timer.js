

private var textMeshComponent;

// store the text component so that GetComponent isn’t called every frame

function Start() {
	textMeshComponent = GetComponent('TextMesh');
}
function Update() {
	textMeshComponent.text = System.DateTime.Now.ToString().Substring(10);
}