<?php

namespace Tests\Unit;

use PHPUnit\Framework\TestCase;

class MyThirdTest extends TestCase
{
    /**
     * A basic unit test example.
     */
    public function test_birthdate_validation(): void
    {
        $validBirthdate = '2000-05-15';
        $isValidValid = $this->isValidBirthdate($validBirthdate);
        $this->assertTrue($isValidValid);

        // Invalid birthdate: February 30, 2024 (does not exist)
        $invalidBirthdate = '2024-02-30';
        $isValidInvalid = $this->isValidBirthdate($invalidBirthdate);
        $this->assertFalse($isValidInvalid);
    }private function isValidBirthdate($birthdate)
    {
        // Validate date format
        if (!preg_match('/^\d{4}-\d{2}-\d{2}$/', $birthdate)) {
            return false;
        }

        // Validate date validity
        [$year, $month, $day] = explode('-', $birthdate);
        return checkdate((int)$month, (int)$day, (int)$year);
    }
}
