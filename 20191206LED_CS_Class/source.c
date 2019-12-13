#include <stdio.h>
#include <avr/io.h>
#include "C:\Users\geozu\source\DriverLibHW\LCD.h"
#include "Wait.h"
#include "USART.h"

char duty_cycle_output[16];

int main(void)
{
	DDRD = ~0x0C;
	PORTD = 0x0C;


	DDRB = 0x60;		// PortB.5 and PortB.6 as Output
	PIND = 0xF3;
	TCCR1A = (1 << WGM10) | (1 << COM1A1) | (1 << COM1A0) | (1 << COM1B1) | (1 << COM1B0);    // Fast PWM 8 Bit, mode 5
	TCCR1B = (1 << WGM12) | (1 << CS12) | (1 << CS10);      // OC1A and OC1B cleared on compare match
															// and set at BOTTOM. Clock Prescaler 1024.
	OCR1A = 254;                           // Dutycycle of OC1A = 0%     
	OCR1B = 127;                          // Dutycycle of OC1B = 50% 


	LCDInit(); // Initialisieren des LCD
	LCDClear(); // Loeschen des LCD
	
	USARTInit(0, 9600, 1, 0, 1, 0);


	LCDString(1, 4, "Duty Cycle ");
	int i = 0;
	int duty_cycle[11] = { 0, 25, 50, 76, 102, 127, 152, 178, 203, 229, 254 };
	int duty_percent[11] = { 00, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
	uint8_t control_char;

	while (1)
	{
		scanf("%s", &control_char);

		switch (control_char)
		{
		case 'y':
			i = 0;
		case 'n':
			i = 10;
		case '+':
			if (i != 0) i--;
		case '-':
			if (i != 10) i++;
		case '++':
			if (i != 2) i -= 2;
		case '--':
			if (i != 8) i += 2;
		}

		OCR1A = duty_cycle[i];
		OCR1B = duty_cycle[i];

		printf("%i\n", duty_percent[i]);


		if (((~PIND & 0x04) >> 2))
		{
			if (i != 0)
			{
				i--;
				OCR1A = duty_cycle[i];
				OCR1B = duty_cycle[i];
				printf("%i\n", duty_percent[i]);
				LCDClearLine(2);
				sprintf(duty_cycle_output, "%i%% ", duty_percent[i]);
				
				LCDString(2, 7, duty_cycle_output);
				WaitMs(200);
			}
			

		}
		else if (((~PIND & 0x08) >> 3))
		{
			if (i != 10)
			{
				i++;
				OCR1A = duty_cycle[i];
				OCR1B = duty_cycle[i];

				printf("%i\n", duty_percent[i]);
				sprintf(duty_cycle_output, "%i%% ", duty_percent[i]);

				LCDClearLine(2);
				LCDString(2, 7, duty_cycle_output);
				WaitMs(200);

			}
		}






	}

}







