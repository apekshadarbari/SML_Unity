#pragma strict


var timer : float = 32.0;

function Update()
{ 
  
    timer -= Time.deltaTime;
       if (timer<=0)
    {    timer = 0;
    }
}

function OnGUI()
{    
    GUI.Box(new Rect(50,100,50,20), "" + timer.ToString("0"));
    
}

