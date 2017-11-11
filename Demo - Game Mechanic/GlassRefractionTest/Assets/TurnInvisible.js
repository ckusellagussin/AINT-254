#pragma strict
var isVisible:boolean = false;
var refractionMaterial: Material;
var dissolveMaterial: Material;
var cloakEngagedClip: AudioClip;
var cloakDisengagedClip: AudioClip;
var enablePlaySound:boolean = true;

var dissolveMaps: Texture[];

private var resolveTime:float = 0;
private var dissolveTime:float = 0;
function Start () {
	refractionMaterial = renderer.materials[1];
	dissolveMaterial = renderer.materials[0];
	audio.clip = cloakDisengagedClip;
}

function Update () {
	transform.Rotate(Vector3.up * Time.deltaTime * 3);
	if(Input.GetKeyDown("f")){
		var index: int;
		if(!isVisible){
			audio.clip = cloakEngagedClip;
			index = Random.Range(0,dissolveMaps.Length);
			renderer.material.SetTexture('_SliceGuide', dissolveMaps[index]);
		}
		else{
			audio.clip = cloakDisengagedClip;
			index = Random.Range(0,dissolveMaps.Length);
			renderer.material.SetTexture('_SliceGuide', dissolveMaps[index]);
		}
		audio.Play();
		isVisible = !isVisible;
	}
	turnVisible();
	turnInvisible();
}

function turnVisible(){
	if(isVisible){
		resolveTime += Time.deltaTime;
		refractionMaterial.SetFloat("_BumpAmt", Mathf.Lerp(0, 70, resolveTime - 0.3));
		dissolveMaterial.SetFloat("_SliceAmount", Mathf.Lerp(0.0, 1.0, resolveTime));
	}
	else{
		resolveTime = 0;
	}
}

function turnInvisible(){
	if(!isVisible){		
		dissolveTime += Time.deltaTime;
		refractionMaterial.SetFloat("_BumpAmt", Mathf.Lerp(70, 0, dissolveTime + 0.3));
		dissolveMaterial.SetFloat("_SliceAmount", Mathf.Lerp(1.0, 0.0, dissolveTime));
	}
	else{
		dissolveTime = 0;
	}
}