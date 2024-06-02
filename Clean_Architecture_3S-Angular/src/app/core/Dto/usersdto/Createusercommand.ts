import { CreateAddressCommand } from "./createaddresscommand";

export interface CreateUserCommand {
    firstName: string;
    middleName: string;
    lastName: string;
    birthDate: string;
    mobileNumber: string;
    email: string;
    addresses: CreateAddressCommand[];
}