export interface IHeaders {
    key: string,
    label: string,
    format?:Number
}

export enum TableFormat {
    Normal=1,
    Image=2,
    Rating=3
}