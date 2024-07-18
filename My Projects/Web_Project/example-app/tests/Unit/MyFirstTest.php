<?php

namespace Tests\Unit;

use PHPUnit\Framework\TestCase;

class MyFirstTest extends TestCase
{
    /**
     * A basic unit test example.
     */
    public function test_is_strong_password(): void
    {
        $strongPassword = 'StrongPassword123!';
        $weakPassword = 'weakpass'; // Too short

        $this->assertTrue($this->isstrongpassword($strongPassword));
        $this->assertFalse($this->isstrongpassword($weakPassword));
    }
    private function isstrongpassword($password)
    {
        // Define your password strength criteria
        $lengthRequirement = 8;
        $hasUppercase = preg_match('/[A-Z]/', $password);
        $hasLowercase = preg_match('/[a-z]/', $password);
        $hasNumber = preg_match('/\d/', $password);
        $hasSpecialCharacter = preg_match('/[!@#$%^&*]/', $password);

        // Check if password meets all criteria
        if (strlen($password) >= $lengthRequirement && $hasUppercase && $hasLowercase && $hasNumber && $hasSpecialCharacter) {
            return true;
        }

        return false;
    }
}
