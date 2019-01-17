//
//  HapticFeedback.m
//  
//
//  Created by Vanik Mkrtchyan on 9/15/17.
//
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

void HeavyFeedback() {
    UIImpactFeedbackGenerator *myGen = [[UIImpactFeedbackGenerator alloc] init];
    [[myGen initWithStyle:(UIImpactFeedbackStyleHeavy)] impactOccurred];
    myGen = NULL;
}

void MediumFeedback() {
    UIImpactFeedbackGenerator *myGen = [[UIImpactFeedbackGenerator alloc] init];
    [[myGen initWithStyle:(UIImpactFeedbackStyleMedium)] impactOccurred];
    myGen = NULL;
}

void LightFeedback() {
    UIImpactFeedbackGenerator *myGen = [[UIImpactFeedbackGenerator alloc] init];
    [[myGen initWithStyle:(UIImpactFeedbackStyleLight)] impactOccurred];
    myGen = NULL;
}
