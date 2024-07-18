<?php

namespace Tests\Unit;

use PHPUnit\Framework\TestCase;

class MyFourthtest extends TestCase
{
    /**
     * A basic unit test example.
     */
    public function test_email_validation(): void
    {
        // Valid email
        $validEmail = 'test@example.com';
        $isValidValid = $this->isValidEmail($validEmail);
        $this->assertTrue($isValidValid);

        // Invalid email
        $invalidEmail = 'invalid-email';
        $isValidInvalid = $this->isValidEmail($invalidEmail);
        $this->assertFalse($isValidInvalid);
    }
    private function isValidEmail($email)
    {
        // Regex pattern for email validation
        $emailRegex = '/^\S+@\S+\.\S+$/';

        // Perform regex matching
        return preg_match($emailRegex, $email) === 1;
    }
}
