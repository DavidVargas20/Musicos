
class circulo {
  constructor(px,py,alto){
    this.fillred=900;
    this.fillgreen= 300;
    this.fillblue=100;
    this.px=px;
    this.py=py;
    this.alto=alto;
  }
  display(){
   
   ellipse(this.px,this.py,this.alto);
  }
  }
  class jugador2  {
    constructor(x, y, alto, ancho, vx, vy) {
     this.posicion = createVector(x,y);
     this.alto = alto;
     this.ancho = ancho;
     this.fillred = 255;
     this.fillgreen = 87;
     this.fillblue = 57;
     this.velocidad = createVector(vx,vy);
   }
   update()
   {
     { if (this.posicion.x + this.ancho >= 800 )
           this.velocidad.x = -1;
           this.velocidad.y =+3;
         }
       this.posicion.add(this.velocidad);
   }
   draw()
  {
fill(this.fillred,this.fillgreen,this.fillblue);
ellipse(this.posicion.x,this.posicion.y,this.alto,this.ancho);
  }
 }
var proyectiles = [];
var dibujando = 'disparar';
function mouseClicked() {
  if (mouseY >1)
    { 
  if (dibujando=='disparar' )
  proyectiles.push(new jugador2 (mouseX,mouseY,10,20,0,1)); 
  return false;
}}
 class jugador1 extends circulo{
   constructor(px,py,alto){
     super(px, py, alto)
   }
   display(){
    fill(this.fillred,this.fillgreen,this.fillblue);
     ellipse(this.px,this.py,this.alto);
   }
   move() {
    if (keyIsDown(LEFT_ARROW)) {
      this.px -= 5;
    }
    if (keyIsDown(RIGHT_ARROW)) {
      this.px += 5;
    }
    if (keyIsDown(UP_ARROW)) {
      this.py -= 5;
    }
    if (keyIsDown(DOWN_ARROW)) {
      this.py += 5;
    }
  }
    }
 let j1;

 function setup() {
   createCanvas(600, 800);
   noStroke();
   
    j1 = new jugador1 (250,350,20,10);
   
    
 }
 
 function draw() {
  background(50,100,200);
  
  proyectiles.forEach((fig) => 
   {
    fig.draw();
    fig.update();
   });
   
  drawAxis();
 
  j1.display();
  j1.move();
 
  
  
  
 
 
   
 }






