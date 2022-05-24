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

// Initialize with pin sequence IN1-IN3-IN2-IN4 for using the AccelStepper with 28BYJ-48
AccelStepper stepper1(HALFSTEP, motorPin1, motorPin3, motorPin2, motorPin4);


void setup() {
  // Bsc function
  stepper1.setMaxSpeed(1000.0);
  stepper1.setAcceleration(100.0);
  stepper1.setSpeed(200);
  stepper1.moveTo(2000);// its a compleate round 

}

void loop() {
  // put your main code here, to run repeatedly:
if (stepper1.distanceToGo() == 0) {
    stepper1.moveTo(-stepper1.currentPosition());
  }
  stepper1.run();
}
