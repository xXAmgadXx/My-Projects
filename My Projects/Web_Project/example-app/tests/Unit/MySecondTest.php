<?php

namespace Tests\Unit;

use PHPUnit\Framework\TestCase;

class MySecondTest extends TestCase
{
    /**
     * A basic unit test example.
     */
    public function test_valid_phone_number(): void
    {
        $validPhone = '01092502819'; // Valid phone number with 11 digits
        $invalidPhone = '012345678'; // Invalid phone number with less than 11 digits

        $this->assertTrue($this->isValidPhoneNumber($validPhone));
        $this->assertFalse($this->isValidPhoneNumber($invalidPhone));
    }
    
        private function isValidPhoneNumber($phone)
    {
        // Validate phone number format
        $phoneRegex = '/^(012|010|011|015)\d{8}$/';

        return preg_match($phoneRegex, $phone) === 1;
    }

        
    
}
