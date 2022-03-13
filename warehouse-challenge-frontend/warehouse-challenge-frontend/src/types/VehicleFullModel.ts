import type VehicleShortModel from "./VehicleShortModel"

export default interface VehicleFullModel extends VehicleShortModel {
	id: number;
	make: string;
	model: string;
	yearModel: number;
	price: number;
	licensed: boolean;
	dateAdded: Date;
}