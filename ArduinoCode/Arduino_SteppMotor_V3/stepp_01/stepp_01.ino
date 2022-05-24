/* 
  DSM_HFK_UNI 
 STEPPER_13_06_2018
 VHR
 */
#include <AccelStepper.h>
#define HALFSTEP 8

#define motorPin1 2
#define motorPin2 3
#define motorPin3 4
#define motorPin4 5

#define motorPinB1 6
#define motorPinB2 7
#define motorPinB3 9
#define motorPinB4 10


const int buttonUp = 11;
const int buttonDown = 12;

int stateBUP = 0;
int stateBDOWN = 0;


// Initialize with pin sequence IN1-IN3-IN2-IN4 for using the AccelStepper with 28BYJ-48
AccelStepper stepper1(HALFSTEP, motorPin1, motorPin3, motorPin2, motorPin4);
AccelStepper stepper2(HALFSTEP, motorPinB1, motorPinB3, motorPinB2, motorPinB4);


void setup() {

    Serial.begin(9600);

  // Bsc function
  stepper1.setMaxSpeed(1000.0);
  stepper1.setAcceleration(100.0);
  stepper1.setSpeed(700);
  stepper1.moveTo(3700);// its a compleate round 


  stepper2.setMaxSpeed(1000.0);
  stepper2.setAcceleration(100.0);
  stepper2.setSpeed(700);
  stepper2.moveTo(3700);// its a compleate round 


  pinMode(buttonUp, INPUT);
  pinMode(buttonDown, INPUT);


}

void loop() {
     //put your main code here, to run repeatedly:

  stateBUP = digitalRead(buttonUp);
  stateBDOWN = digitalRead(buttonDown);
  


//  if (stepper1.distanceToGo() == 0) {
  //  stepper1.moveTo(-stepper1.currentPosition());
  //}
  //stepper1.run();

    if (stateBUP == HIGH){
      stepper1.run();
      stepper2.run();
      Serial.println("buttonPressed");

  }

/*  if(stateBDOWN == HIGH){

    stepper1.setSpeed(-200);
    stepper1.run();

    }*/

Serial.println(stateBUP);

 


   
  
}
